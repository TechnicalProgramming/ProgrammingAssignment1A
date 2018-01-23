using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingAssignment1BusStop
{
    /// <summary>
    /// Clears all the form components to default state
    /// </summary>
    public sealed class ResetComponents
    {
        #region Fields

        private static object syncRoot = new object();
        private static volatile ResetComponents instance;
        private bool travelTimeTextBoxCleared = false;
        private bool travelDistanceTextBoxCleared = false;
        private bool travelTimeResultTextBox = false;
        private bool travelDistanceResultTextBox = false;

        #endregion

        #region Constructor
        /// <summary>
        /// Private constructor
        /// </summary>
        private ResetComponents() { }
        #endregion

        #region Properties
        /// <summary>
        /// Singleton desing patterns
        /// </summary>
        public static ResetComponents Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ResetComponents();
                    }
                }
                return instance;
            }
        }
        public bool TravelTimeTextBoxCleared { get {return travelTimeTextBoxCleared; } set { travelTimeTextBoxCleared = value; } }
        public bool TravelDistanceTextBox { get {return TravelDistanceTextBox; } set { TravelDistanceTextBox = value; } }
        public bool TravelTimeResultTextBox { get {return travelTimeResultTextBox; } set { travelTimeResultTextBox = value; } }
        public bool TravelDistanceResultTextBox { get {return travelDistanceResultTextBox; } set { travelDistanceResultTextBox = value; } }

        #endregion

        #region Methods
        /// <summary>
        /// Clears the text from the travel time textbox
        /// </summary>
        /// <returns></returns>
        public bool ResetTravelTimeTextBox(TextBox travelTimeTextBox)
        {
            try
            {
                // Clear the text
                travelTimeTextBox.Text = "";
                // Log that the text has been cleared
                travelTimeTextBoxCleared = true;
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="travelDistanceTextBox"></param>
        /// <returns></returns>
        public bool ResetTravelDistanceTextBox(TextBox travelDistanceTextBox)
        {
            try
            {
                // Clear the text
                travelDistanceTextBox.Text = "";
                // Log that the text has been cleared
                travelDistanceTextBoxCleared = true;
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
        #endregion


    }
}
