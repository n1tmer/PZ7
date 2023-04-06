﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ7
{
    internal class App: IObservable
    {
        List<User> users;
        List<Celebration> celebrations;
        DateTime time;
        public App()
        {
            users = new List<User>()
            {
            new User("Олег", Root.VIP),
            new User("Константин", Root.Amateur),
            new User("Владимир", Root.Rookie)
            };
            celebrations = new List<Celebration>()
            {
                new Celebration(new DateTime(2023,3,8), "Международный женский день",Root.VIP),
                new Celebration (new DateTime(2023,5,9),"День Победы", Root.VIP),
                new Celebration (new DateTime(2023,5,9),"День Победы", Root.Amateur),
                new Celebration (new DateTime(2023,5,9),"День Победы", Root.Amateur)
            };
            Check();



        }
        public void AddObserver(User us)
        {
            users.Add(us);
            Check();
        }
        private void Check()
        {
            time = new DateTime(2023, Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            foreach (var item in celebrations)
            {
                if (item.Check(time)) NotifyObservers(item);
            }
        }

        public void NotifyObservers(Celebration name)
        {
            foreach (var user in users)
            {

                user.Notify(name);
            }
        }

        public void RemoveObserver(User us)
        {
            users.Remove(us);
            Check();
        }
    }
}
