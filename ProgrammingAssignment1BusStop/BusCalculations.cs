using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1BusStop
{
    public sealed class BusCalculations
    {
        #region Fields
        private float travelTime = 0.0f;
        private float travelDistance = 0.0f;
        private const int busSpeedKM = 80;
        private const float busSpeedMin = 1.33f;
        private static volatile BusCalculations instance;
        private static object syncRoot = new object();
        #endregion

        #region Constructor
        /// <summary>
        /// Private constructor
        /// </summary>
        private BusCalculations() { }
        #endregion

        #region Properties
        public float TravelTime { get {return travelTime; } set {travelTime = value; } }
        public float TravelDistance { get {return travelDistance; } set {travelDistance = value; } }
        public static BusCalculations Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new BusCalculations();
                    }
                }
                return instance;
            }
        }

        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="travelTimes"></param>
        /// <returns></returns>
        public float CalculateDistance(float travelTime)
        {
            try
            {
                travelDistance = travelTime * busSpeedMin;
                return 0f;
            }catch(Exception ex)
            {
                return 0f;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="travelDistance"></param>
        /// <returns></returns>
        public float CalculateTime(float travelDistance)
        {
            try
            {
                travelTime = travelDistance / busSpeedMin;
                return 0f;
            }catch(Exception ex)
            {
                return 0f;
            }
        }
        #endregion
    }
}
