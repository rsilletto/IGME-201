﻿/* Rose Silletto
 * IGME 201
 * PE 11 Class Structures
 * Oct. 11 2022
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_2
{
    public interface IPassengerCarrier
    {
        void LoadPassengers();
    }

    public interface IHeavyLoadCarrier
    {

    }

    public class Compact : Car, IPassengerCarrier
    {
        public void LoadPassengers()
        {

        }
    }

}
