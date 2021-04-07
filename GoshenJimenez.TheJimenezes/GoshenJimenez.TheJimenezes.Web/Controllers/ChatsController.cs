using GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain;
using GoshenJimenez.TheJimenezes.Web.Infrastructure.Localization;
using GoshenJimenez.TheJimenezes.Web.ViewModels.Chats;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace GoshenJimenez.TheJimenezes.Web.Controllers
{
    public class ChatsController : Controller
    {
        private readonly IHubContext<SignalHub> _hubContext;
        private readonly ILogger<ChatsController> _logger;
        private readonly IStringLocalizer _localizer;
        private readonly DefaultDbContext _context;
        public ChatsController(ILogger<ChatsController> logger, IStringLocalizerFactory factory, DefaultDbContext context, IHubContext<SignalHub> hubContext)
        {
            var type = typeof(StringResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _localizer = factory.Create("StringResource", assemblyName.Name);
            _logger = logger;
            _context = context;
            _hubContext = hubContext;
        }


        [HttpGet("chat/{shopOwnerId}")]
        public IActionResult Chat(Guid? shopOwnerId = null)
        {
            Guid? userId = Guid.Parse("49f3e387-3157-4125-88ae-cb35e2e9e86c");
            if(shopOwnerId != null)
            {
                var chatThreadIds = _context.ChatUsers
                                            .Where(u => u.UserId == userId)
                                            .Select(u => u.ChatThreadId)
                                            .ToList();

                var chatUser= _context.ChatUsers
                                            .FirstOrDefault(u => chatThreadIds.Contains(u.ChatThreadId) && u.UserId == shopOwnerId);
                
                Guid? chatThreadId = null;    
                if(chatUser != null)
                {
                    chatThreadId = chatUser.ChatThreadId;
                }

                var chatThread = _context.ChatThreads.FirstOrDefault(t => t.Id == chatThreadId);

                if(chatThread == null)
                {
                    chatThread = new Infrastructure.Domain.Models.ChatThread()
                    {
                        Id = Guid.NewGuid(),
                        UpdatedAt = DateTime.Now
                    };

                    var myChatUser = new Infrastructure.Domain.Models.ChatUser()
                    {
                        UserId = userId,
                        ChatThreadId = chatThread.Id,
                    };
                        
                    var shopOwnerChatUser = new Infrastructure.Domain.Models.ChatUser()
                    {
                        UserId = shopOwnerId,
                        ChatThreadId = chatThread.Id,
                    };


                    _context.ChatThreads.Add(chatThread);
                    _context.ChatUsers.Add(myChatUser);
                    _context.ChatUsers.Add(shopOwnerChatUser);

                    _context.SaveChanges();
                }
            }

            return RedirectPermanent("/chats/" + userId);
        }

        [HttpGet("chats/{userId}")]
        public IActionResult Index(Guid? userId = null)
        {

            var chatThreadIds = _context.ChatUsers.Include(u => u.ChatThread)
                                        .Where(u => u.UserId == userId)
                                        .OrderByDescending(u => u.ChatThread.UpdatedAt)
                                        .Take(10)
                                        .Select(u => u.ChatThreadId)
                                        .ToList();

            var chatUsers = _context.ChatUsers.Include(u => u.User).Include(u => u.ChatThread)
                                        .Where(u => chatThreadIds.Contains(u.ChatThreadId) && u.UserId != userId)
                                        .Select(u => new ChatThreadViewModel()
                                        {
                                            ChatThreadId = u.ChatThreadId,
                                            UserId = u.UserId,
                                            UserName = u.User.FullName,
                                            LastMessageDate = u.ChatThread.UpdatedAt
                                        })
                                        .ToList();

            var chatMessages = _context.ChatMessages.Include(u => u.User)
                                        .Where(m => m.ChatThreadId == chatThreadIds.FirstOrDefault())
                                        .OrderByDescending(u => u.ChatThread.UpdatedAt)
                                        .Take(10)
                                        .Select(u => new ChatMessageViewModel()
                                        {
                                            UserId = u.UserId,
                                            UserName = u.User.FullName,
                                            MessageDate = u.CreatedAt,
                                            Message = u.Message
                                        })
                                        .ToList();

            return View(new ViewModels.Chats.IndexViewModel()
            {
                ChatMessages = chatMessages,
                ChatThreads = chatUsers,
                UserId = userId
            });
        }
    }
}
