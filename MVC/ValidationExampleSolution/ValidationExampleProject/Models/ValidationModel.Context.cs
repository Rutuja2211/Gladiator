﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ValidationExampleProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbDiscShopEntities : DbContext
    {
        public dbDiscShopEntities()
            : base("name=dbDiscShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<Gamer> Gamers { get; set; }
        public virtual DbSet<Game> Games { get; set; }
    
        public virtual int proc_register_user(string un, string pass, string uname, Nullable<int> uage, string urole, string status)
        {
            var unParameter = un != null ?
                new ObjectParameter("un", un) :
                new ObjectParameter("un", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            var unameParameter = uname != null ?
                new ObjectParameter("uname", uname) :
                new ObjectParameter("uname", typeof(string));
    
            var uageParameter = uage.HasValue ?
                new ObjectParameter("uage", uage) :
                new ObjectParameter("uage", typeof(int));
    
            var uroleParameter = urole != null ?
                new ObjectParameter("urole", urole) :
                new ObjectParameter("urole", typeof(string));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_register_user", unParameter, passParameter, unameParameter, uageParameter, uroleParameter, statusParameter);
        }
    
        public virtual ObjectResult<proc_LoginCheck_Result> proc_LoginCheck(string un, string pass)
        {
            var unParameter = un != null ?
                new ObjectParameter("un", un) :
                new ObjectParameter("un", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_LoginCheck_Result>("proc_LoginCheck", unParameter, passParameter);
        }
    
        public virtual int proc_add_gamers(Nullable<int> id, string player, Nullable<int> gameid, string score)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var playerParameter = player != null ?
                new ObjectParameter("player", player) :
                new ObjectParameter("player", typeof(string));
    
            var gameidParameter = gameid.HasValue ?
                new ObjectParameter("gameid", gameid) :
                new ObjectParameter("gameid", typeof(int));
    
            var scoreParameter = score != null ?
                new ObjectParameter("score", score) :
                new ObjectParameter("score", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_add_gamers", idParameter, playerParameter, gameidParameter, scoreParameter);
        }
    
        public virtual ObjectResult<proc_users_score_Result> proc_users_score(Nullable<int> gameid)
        {
            var gameidParameter = gameid.HasValue ?
                new ObjectParameter("gameid", gameid) :
                new ObjectParameter("gameid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_users_score_Result>("proc_users_score", gameidParameter);
        }
    
        public virtual ObjectResult<string> proc_games()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("proc_games");
        }

        public System.Data.Entity.DbSet<ValidationExampleProject.Models.proc_users_score_Result> proc_users_score_Result { get; set; }
    }
}