using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using litclassic.LitClassicBooksModels;
using litclassic.Models.ParticleModels;
using litclassic.Models.ProxyModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace litclassic.Controllers
{
    // TODO
    // Реализовать получение "частиц" с помощью AJAX
    // https://metanit.com/sharp/mvc5/10.3.php

    [Authorize]
    public class ParticlesController : Controller
    {
        private readonly IParticleProxy _particleProxy;
        private readonly IParticleParamsProxy _particleParamsProxy;
        private readonly LitClassicBooksContext _db;

        public ParticlesController(IParticleProxy particleProxy, IParticleParamsProxy particleParamsProxy, LitClassicBooksContext db)
        {
            _particleProxy = particleProxy;
            _particleParamsProxy = particleParamsProxy;
            _db = db;
        }

        // GET: Particle
        [AllowAnonymous]
        public ActionResult Index()
        {
            var particleViewModel = new ParticleViewModel(_particleProxy, _particleParamsProxy, _db);

            particleViewModel.BuildModel(8);

            ViewBag.Particles = particleViewModel.ParticlePartialViewModel.Particles;
            ViewBag.ParticleParams = particleViewModel.ParticleParams;

            return View();
        }

        [AllowAnonymous]
        // GET: Particle/InfiniteScrolling
        public ActionResult InfiniteScrolling()
        {
            var particlePartialViewModel = new ParticlePartialViewModel(_particleProxy, _db);

            particlePartialViewModel.BuildModel(4);

            ViewBag.Particles = particlePartialViewModel.Particles;

            return PartialView("_Particle");
        }

        [AllowAnonymous]
        public ActionResult Menu()
        {
            return PartialView("_Menu");
        }

        // GET: Particle/Favourite
        [Authorize]
        public ActionResult Favourite()
        {
            return View();
        }      
    }
}