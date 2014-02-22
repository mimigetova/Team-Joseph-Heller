﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjaWars
{
    public class EnemyShip : Ship
    {
        private static readonly char[,] enemyShipBody = new char[,] { { '%' }, { '%' } };
        private static readonly MatrixCoord defaultEnemySpeed = new MatrixCoord(1, 0);

        public EnemyShip(int col)
            : base(new MatrixCoord(enemyShipBody.GetUpperBound(0), col), enemyShipBody, defaultEnemySpeed)
        {
        }

        public override MovingObject Fire()
        {
            throw new NotImplementedException();
        }
    }
}