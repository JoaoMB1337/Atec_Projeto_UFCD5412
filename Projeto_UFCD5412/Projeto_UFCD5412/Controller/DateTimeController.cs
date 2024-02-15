using System;

namespace Projeto_UFCD5412.Controller
{
    internal class DateTimeController
    {
        private static DateTimeController instance;
        private DateTime currentDateTime;

        public static event EventHandler<DateTimeChangedEventArgs> DateTimeChanged;

        public static DateTimeController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DateTimeController();
                }
                return instance;
            }
        }

        public DateTime CurrentDateTime
        {
            get { return currentDateTime; }
            private set
            {
                if (currentDateTime != value)
                {
                    currentDateTime = value;
                    OnDateTimeChanged(new DateTimeChangedEventArgs(value));
                }
            }
        }

        public DateTime GetDateTime()
        {
            return CurrentDateTime;
        }

        public void SetDateTime(DateTime dateTime)
        {
            CurrentDateTime = dateTime;
            OnDateTimeChanged(new DateTimeChangedEventArgs(dateTime));
        }

        public DateTime AddDays(DateTime dateTime, int days)
        {
            return dateTime.AddDays(days);
        }

        private void OnDateTimeChanged(DateTimeChangedEventArgs e)
        {
            DateTimeChanged?.Invoke(this, e);
        }
    }

    public class DateTimeChangedEventArgs : EventArgs
    {
        public DateTime NewDateTime { get; }

        public DateTimeChangedEventArgs(DateTime newDateTime)
        {
            NewDateTime = newDateTime;
        }
    }
}
