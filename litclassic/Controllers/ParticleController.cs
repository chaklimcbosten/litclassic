﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using litclassic.Models;
using litclassic.Models.ParticleModels;
using litclassic.Models.ProxyModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace litclassic.Controllers
{
    [Authorize]
    public class ParticleController : Controller
    {
        private readonly IParticleProxy _particleProxy;
        private readonly IParticleParamsProxy _particleParamsProxy;
        private readonly LitClassicBooksContext _db;

        public ParticleController(IParticleProxy particleProxy, IParticleParamsProxy particleParamsProxy, LitClassicBooksContext db)
        {
            _particleProxy = particleProxy;
            _particleParamsProxy = particleParamsProxy;
            _db = db;
        }

        // GET: Particle
        [AllowAnonymous]
        public ActionResult Index()
        {
            var particleViewModel = new ParticleViewModel(_particleProxy, _db);
            var particleParams = new ParticleParams()
            {
                Authors = new List<string> { "Достоевский", "Пушкин" },
                ThemeTypes = new List<string> { "основные", "ещё" }
            };

            particleViewModel.BuildModel(true, 1);

            ViewBag.Particles = particleViewModel.Particles;
            ViewBag.ParticleParams = particleParams;

            return View();
        }

        public ActionResult Menu()
        {
            return PartialView("_Menu");
        }

        // GET: Particle/Favourite
        public ActionResult Favourite()
        {
            return View();
        }

        // GET: Particle/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Particle/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Particle/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Particle/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Particle/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Particle/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Particle/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}