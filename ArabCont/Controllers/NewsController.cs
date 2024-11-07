using ArabCont.BLL.Interfaces;
using ArabCont.DAL.Models;
using ArabCont.PL.ViewModels;
using AutoMapper;
using Demo.PL.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace ArabCont.PL.Controllers
{
    public class NewsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public NewsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<News> news;
            news = await _unitOfWork.NewsRepository.GetAllAsync();
            var MappedNews = _mapper.Map<IEnumerable<NewsViewModel>>(news);
            return View(MappedNews);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(NewsViewModel newsVM)
        {
            if (ModelState.IsValid)
            {
                if (newsVM.Image != null && newsVM.Image.Length > 0)
                {
                    // Save the image to the file system or wherever needed
                    newsVM.ImageName = DocumentSettings.UploadFile(newsVM.Image, "Images");
                }
                var MappedNews = _mapper.Map<News>(newsVM);
                await _unitOfWork.NewsRepository.AddAsync(MappedNews);
                await _unitOfWork.CompleteAsync();
                return RedirectToAction(nameof(newsVM));
            }
            return View(newsVM);
        }
    }
}
