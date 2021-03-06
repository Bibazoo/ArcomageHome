﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arcomage.Core.ArcomageService;
using Arcomage.Entity;
using Newtonsoft.Json;
using NUnit.Framework.Constraints;

namespace Arcomage.Tests.Moq
{
    class TestServer : IArcoServer
    {
        public string GetRandomCard()
        {
            List<Card> returnVal = new List<Card>();

            var paramsM = new List<CardParams>();
            paramsM.Add(new CardParams() {key = Specifications.EnemyTower, value = -50});
            paramsM.Add(new CardParams() { key = Specifications.CostAnimals, value = 0 });

            returnVal.Add(new Card()
            {
                id = 1,
                cardParams = paramsM
            });


            /* Стартовые значения игрока 
           * 
           * returnVal.Add(Specifications.PlayerWall, 5);
          returnVal.Add(Specifications.PlayerTower, 10);

          returnVal.Add(Specifications.PlayerMenagerie, 1);
          returnVal.Add(Specifications.PlayerColliery, 1);
          returnVal.Add(Specifications.PlayerDiamondMines, 1);

          returnVal.Add(Specifications.PlayerRocks, 5);
          returnVal.Add(Specifications.PlayerDiamonds, 5);
          returnVal.Add(Specifications.PlayerAnimals, 5);*/

            var paramsM2 = new List<CardParams>();
            paramsM2.Add(new CardParams() { key = Specifications.PlayerTower, value = -8 });
            paramsM2.Add(new CardParams() { key = Specifications.PlayerWall, value = -4 });
            paramsM2.Add(new CardParams() { key = Specifications.PlayerDiamondMines, value = 2 });
            paramsM2.Add(new CardParams() { key = Specifications.PlayerMenagerie, value = 3 });
            paramsM2.Add(new CardParams() { key = Specifications.PlayerColliery, value = 4 });
            paramsM2.Add(new CardParams() { key = Specifications.PlayerDiamonds, value = 11 });
            paramsM2.Add(new CardParams() { key = Specifications.PlayerAnimals, value = 12 });
            paramsM2.Add(new CardParams() { key = Specifications.PlayerRocks, value = 13 });

            paramsM2.Add(new CardParams() { key = Specifications.EnemyTower, value = -8 });
            paramsM2.Add(new CardParams() { key = Specifications.EnemyWall, value = -4 });
            paramsM2.Add(new CardParams() { key = Specifications.EnemyDiamondMines, value = 2 });
            paramsM2.Add(new CardParams() { key = Specifications.EnemyMenagerie, value = 3 });
            paramsM2.Add(new CardParams() { key = Specifications.EnemyColliery, value = 4 });
            paramsM2.Add(new CardParams() { key = Specifications.EnemyDiamonds, value = 11 });
            paramsM2.Add(new CardParams() { key = Specifications.EnemyAnimals, value = 12 });
            paramsM2.Add(new CardParams() { key = Specifications.EnemyRocks, value = 13 });
            
            paramsM2.Add(new CardParams() { key = Specifications.CostAnimals, value = 5 });

            returnVal.Add(new Card()
            {
                id = 2,
                cardParams = paramsM2
            });


            var paramsM3 = new List<CardParams>();
            paramsM3.Add(new CardParams() { key = Specifications.GetCard, value = -50 });
            paramsM3.Add(new CardParams() { key = Specifications.EnemyDirectDamage, value = -50 });
            paramsM3.Add(new CardParams() { key = Specifications.PlayerDirectDamage, value = -50 });

            returnVal.Add(new Card()
            {
                id = 3,
                cardParams = paramsM3
            });

            return JsonConvert.SerializeObject(returnVal);
        }
    }
}
