using System;
using System.Collections.Generic;
using System.Data.Entity;
using DeliverBackend.Models;

namespace DeliverBackend.App_Start
{
    public class MobileServiceInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            DateTime inceptionDate = DateTime.SpecifyKind(new DateTime(2017, 4, 1, 0, 0, 0), DateTimeKind.Utc);

            var rols = new List<Rol>()
            {
                new Rol() { Id = "953d9588-e6be-49cf-881d-68431b8285c3", Description = "Administrator", CreatedAt = inceptionDate, UpdatedAt = inceptionDate.AddDays(5), Deleted = false},
                new Rol() {  Id = "450fe593-433f-4bca-9f39-f2a0e4c64dc6", Description = "User", CreatedAt = inceptionDate, UpdatedAt = inceptionDate.AddDays(4), Deleted = false},
                new Rol() {  Id = "5c957b8f-6e76-470c-941f-789d12f10a42",Description = "DeliverMan", CreatedAt = inceptionDate, UpdatedAt = inceptionDate.AddDays(3), Deleted = false},
            };

            rols.ForEach(a => context.Set<Rol>().Add(a));

            var users = new List<User>()
            {
                new User() {Id = "FCA250D4-98EE-467D-B764-D3A43DEDE18B", RolId = "953d9588-e6be-49cf-881d-68431b8285c3", Name = "Admnistrador", Surnames = "Principal", BirthdayDate = inceptionDate, Photo = "https://xamarincrmv2.blob.core.windows.net/images/fan01.jpg", Email = "manu_cg19@hotmail.com", Password = "1234", Points = 100,  CreatedAt = inceptionDate, UpdatedAt = inceptionDate.AddDays(5), Deleted = false},
                new User() {Id = "FC4284FA-DEEC-47A7-AF39-13225B119C6D", RolId = "450fe593-433f-4bca-9f39-f2a0e4c64dc6", Name = "Usuario", Surnames = "Principal", BirthdayDate = inceptionDate, Photo = "https://xamarincrmv2.blob.core.windows.net/images/stepperMotor01.jpg", Email = "manu_cg15@hotmail.com", Password = "1234", Points = 100,  CreatedAt = inceptionDate, UpdatedAt = inceptionDate.AddDays(5), Deleted = false},
             };
            users.ForEach(a => context.Set<User>().Add(a));

            var repartidores = new List<Transporter>()
            {
                new Transporter() {Id = "FA0C9888-A633-4D1D-8266-B75DE54EEB7D",  Name = "Repartidor", Surnames = "Principal", BirthdayDate = inceptionDate, Photo = "https://xamarincrmv2.blob.core.windows.net/images/extruder04.jpg", Email = "manucg18@gmail.com", Password = "1234", Points = 100,  CreatedAt = inceptionDate, UpdatedAt = inceptionDate.AddDays(5), Deleted = false}
            };
            repartidores.ForEach(a => context.Set<Transporter>().Add(a));

            var mobiles = new List<Mobile>()
            {
                new Mobile() { Id = "9CD6310F-1439-4898-9F51-EEC96D032CD3", TransporterId = "FA0C9888-A633-4D1D-8266-B75DE54EEB7D", MobileType = 1, Description = "Moto", CreatedAt = inceptionDate, UpdatedAt = inceptionDate.AddDays(3), Deleted = false},
            };
            mobiles.ForEach(a => context.Set<Mobile>().Add(a));

            var cards = new List<Card>()
            {
                new Card() {Id = "70EB3223-4ED2-4FE2-9AC1-F72B474FF05F", UserId = "FC4284FA-DEEC-47A7-AF39-13225B119C6D", Name = "Usuario Apellido", ExpirationDate = inceptionDate, Number = 123456789012, Cvv = 123, CreatedAt = inceptionDate, UpdatedAt = inceptionDate.AddDays(3), Deleted = false }
            };
            cards.ForEach(a => context.Set<Card>().Add(a));

            var address = new List<Address>()
            {
                new Address() {Id = "D5E85894-129F-4F39-A75D-893DAB128ECD", UserId = "FC4284FA-DEEC-47A7-AF39-13225B119C6D", Description = "Mi Casa",  CreatedAt = inceptionDate, UpdatedAt = inceptionDate.AddDays(3), Deleted = false},
            };
            address.ForEach(a => context.Set<Address>().Add(a));

            var orders = new List<Order>()
            {
                new Order() { Id = "DAFB9C5C-54A3-4F18-BC01-10AD2491AEC7", UserId = "FC4284FA-DEEC-47A7-AF39-13225B119C6D", TransporterId = "FA0C9888-A633-4D1D-8266-B75DE54EEB7D", AddressId = "D5E85894-129F-4F39-A75D-893DAB128ECD" ,IsOpen = true, Price = 20, OrderDate = inceptionDate, SendType = 1,CreatedAt = inceptionDate, UpdatedAt = inceptionDate.AddDays(5), Deleted = false},
            };
            orders.ForEach(a => context.Set<Order>().Add(a));

            var recivers = new List<Receiver>()
            {
                new Receiver() {Id = "AB6F1601-94F3-4E32-A08A-089B5B52DA36" , Name = "Entrega Nombre", Address = "Su casa", Phone = "12345678", CreatedAt = inceptionDate, UpdatedAt = inceptionDate.AddDays(5), Deleted = false},
            };
            recivers.ForEach(a => context.Set<Receiver>().Add(a));


            var products = new List<Product>()
           {
               new Product() { Id = "6CF4DE3E-FE50-4860-8E5C-6DCF479D4737", Name = "Envio", Description = "Envio a domicilio", CreatedAt = inceptionDate, UpdatedAt = inceptionDate.AddDays(5), Deleted = false},
           };
            products.ForEach(a => context.Set<Product>().Add(a));

            var orderDetails = new List<OrderDetail>()
            {
                new OrderDetail() { Id = "CA0A6161-6898-421D-9F29-A51B60F36BEE", OrderId = "DAFB9C5C-54A3-4F18-BC01-10AD2491AEC7", ProductId = "6CF4DE3E-FE50-4860-8E5C-6DCF479D4737", Quantity = 1, UnitPrice = 10, Discount = 1, CreatedAt = inceptionDate, UpdatedAt = inceptionDate.AddDays(5), Deleted = false},
            };
            orderDetails.ForEach(a => context.Set<OrderDetail>().Add(a));

            base.Seed(context);
        }
    }
}