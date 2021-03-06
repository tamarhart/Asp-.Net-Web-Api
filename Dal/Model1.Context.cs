﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class kindergardenEntities : DbContext
    {
        public kindergardenEntities()
            : base("name=kindergardenEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ArrivalChildren> ArrivalChildren { get; set; }
        public virtual DbSet<Children> Children { get; set; }
        public virtual DbSet<Connections> Connections { get; set; }
        public virtual DbSet<DailyAlerts> DailyAlerts { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    
        public virtual ObjectResult<string> empGetChildIdSp()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("empGetChildIdSp");
        }
    
        public virtual ObjectResult<Nullable<bool>> empGetChildIsComingSp(string childId)
        {
            var childIdParameter = childId != null ?
                new ObjectParameter("ChildId", childId) :
                new ObjectParameter("ChildId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<bool>>("empGetChildIsComingSp", childIdParameter);
        }
    
        public virtual ObjectResult<Nullable<bool>> empGetChildIsMissingSp(string childId)
        {
            var childIdParameter = childId != null ?
                new ObjectParameter("ChildId", childId) :
                new ObjectParameter("ChildId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<bool>>("empGetChildIsMissingSp", childIdParameter);
        }
    
        public virtual ObjectResult<string> empGetChildSp(string userId)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("empGetChildSp", userIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> empGetPasswordSp(string password)
        {
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("empGetPasswordSp", passwordParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> empGetTopUserIdSp()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("empGetTopUserIdSp");
        }
    
        public virtual ObjectResult<string> empGetUserIdSp(string childId)
        {
            var childIdParameter = childId != null ?
                new ObjectParameter("ChildId", childId) :
                new ObjectParameter("ChildId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("empGetUserIdSp", childIdParameter);
        }
    
        public virtual ObjectResult<string> empGetUserSp(string userId)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("empGetUserSp", userIdParameter);
        }
    }
}
