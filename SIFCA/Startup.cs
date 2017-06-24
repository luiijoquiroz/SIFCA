using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using SIFCA.Models;

[assembly: OwinStartupAttribute(typeof(SIFCA.Startup))]
namespace SIFCA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }


        // En este método, crearemos roles de usuario predeterminados y usuario de administrador para el inicio de sesión
        private void createRolesandUsers()
    {
        ApplicationDbContext context = new ApplicationDbContext();

        var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
        var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            // En Startup estoy creando la primera función de administrador y creando un usuario de administrador predeterminado
            if (!roleManager.RoleExists("Admin"))
        {

            // Primero creamos el rol de Administrador
            var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
            role.Name = "Admin";
            roleManager.Create(role);

            //Here we create a Admin super user who will maintain the website                  

            var user = new ApplicationUser();
            user.UserName = "Master";
            user.Email = "Master@hotmail.com";

            string userPWD = "Master123.";

            var chkUser = UserManager.Create(user, userPWD);

            //Add default User to Role Admin   
            if (chkUser.Succeeded)
            {
                var result1 = UserManager.AddToRole(user.Id, "Admin");

            }
        }

        // creating Creating Manager role    
        if (!roleManager.RoleExists("Administrador"))
        {
            var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
            role.Name = "Administrador";
            roleManager.Create(role);

        }

            // creating Creating Usuario role    
            if (!roleManager.RoleExists("Usuario"))
        {
            var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
            role.Name = "Usuario";
            roleManager.Create(role);

        }
            // creating Creating Socio role    
            if (!roleManager.RoleExists("Socio"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Socio";
                roleManager.Create(role);

            }
        }
    }


}


