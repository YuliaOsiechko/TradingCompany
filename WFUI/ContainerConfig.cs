using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using BLL;
using DAL;

namespace WFUI
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<SignInForm>().AsSelf();
            builder.RegisterType<SignUpForm>().AsSelf();
            builder.RegisterType<MainForm>().AsSelf();
            //builder.RegisterType<CommentsForm>().AsSelf();
            builder.RegisterType<TextPromptForm>().AsSelf();

            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(BLL)))
            //    .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == 'I' + t.Name));

            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(DAL)))
            //    .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == 'I' + t.Name));

            builder.RegisterType<ManagerRepository>().As<IManagerRepository>();
            builder.RegisterType<InvoiceRepository>().As<IInvoiceRepository>();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>();

            builder.RegisterType<ManagerServices>().As<IManagerServices>();
            builder.RegisterType<OrderServices>().As<IOrderServices>();
            builder.RegisterType<InvoiceServices>().As<IInvoiceServices>();

            return builder.Build();
        }
    }
}
