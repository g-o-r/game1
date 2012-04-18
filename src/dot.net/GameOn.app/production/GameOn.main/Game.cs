using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GameOn.main
{

    public delegate void NewTurnStartedEventHandler(object sender, EventArgs e);

    public class Game
    {
        public event NewTurnStartedEventHandler NewTurnStarted;

        List<Person> _people = new List<Person>();
        Thread _gameThread;
        System.Timers.Timer _time;

        internal void AddPerson()
        {
            _people.Add(new Person());
        }

        internal void Start()
        {
            _time = new System.Timers.Timer(33);
            _time.Elapsed += RunTurn;
            _time.Enabled = true;
        }

        private void RunTurn(object sender, System.Timers.ElapsedEventArgs e)
        {
            NewTurnStarted(this, new EventArgs());
        }
    }
}
