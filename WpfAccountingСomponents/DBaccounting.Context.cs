﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfAccountingСomponents
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBEquipmentAccountingEntities : DbContext
    {
        private static DBEquipmentAccountingEntities _context;

        public DBEquipmentAccountingEntities()
            : base("name=DBEquipmentAccountingEntities")
        {
        }
        
        public static DBEquipmentAccountingEntities GetContext()
        {
            if(_context == null)
            {
                _context = new DBEquipmentAccountingEntities();
            }

            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<FinanciallyResponsiblePersons> FinanciallyResponsiblePersons { get; set; }
        public virtual DbSet<IssueRegistrationLog> IssueRegistrationLog { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TypesOfEquipment> TypesOfEquipment { get; set; }
    }
}
