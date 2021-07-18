using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Azure.Extensions.AspNetCore.Configuration.Secrets;
using Azure.Identity;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

namespace IdentityApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) =>
                {
                    if (context.HostingEnvironment.IsProduction())
                    {
                        // add ceriticate p12 file to ~/.dotnet/corefx/cryptography/x509stores
                        //Create new X509 store called teststore from the local certificate store.
                        X509Store storeW = new X509Store (StoreName.My, StoreLocation.CurrentUser);
                        storeW.Open (OpenFlags.ReadWrite);
                        X509Certificate2 certificate = new X509Certificate2 ();
                        //Create certificates from certificate files.
                        //You must put in a valid path to three certificates in the following constructors.
                        X509Certificate2 certificate1 = new X509Certificate2 ("/home/edwardhsueh/Documents/GitHub/azure/cert_key.p12","domy5619");
                        //Add certificates to the store.
                        storeW.Add (certificate1);
                        //Close the store.
                        storeW.Close ();                        
                        var builtConfig = config.Build();
                        // using var store = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
                        using var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                        store.Open(OpenFlags.ReadOnly);
                        Console.WriteLine($"context is Prodcution:{store.Location}");
                        var certs = store.Certificates.Find(
                            X509FindType.FindByThumbprint,
                            builtConfig["AzureADCertThumbprint"], false);
                        Console.WriteLine($"context is Prodcution:{certs.Count}");
                        foreach (var cert in certs)
                        {
                            Console.WriteLine($"cert: {cert.IssuerName.Name}");
                        }                        


                        config.AddAzureKeyVault(new Uri($"https://{builtConfig["KeyVaultName"]}.vault.azure.net/"),
                                                new ClientCertificateCredential(builtConfig["AzureADDirectoryId"], builtConfig["AzureADApplicationId"], certs.OfType<X509Certificate2>().Single()),
                                                new KeyVaultSecretManager());

                        store.Close();
                    }
                })            
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
