﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace SklepInternetowy.Infrastructure
{
    public class SessionMenager : IsessionMenager
    {
        private HttpSessionState session;
        public SessionMenager()
        {
            session = HttpContext.Current.Session;
        } 

        public void Abandon()
        {
            session.Abandon();
        }

        public T Get<T>(string key)
        {
            return (T)session[key];
        }

        public void Set<T>(string name, T value)
        {
            session[name] = value;
        }

        public T TryGet<T>(string key)
        {
            try
            {
                return (T)session[key];
            }
            catch (NullReferenceException)
            {
                return default(T);
            }
        }
    }
}