using My2Gov.Proxy;
using My2Gov.Proxy.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My2Gov.Proxy.Clients;

namespace My2Gov.Demo
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Samples().GetAwaiter().GetResult();

            Console.ReadKey();
        }

        private static async Task Samples()
        {
            var values = new Dictionary<string, object>
            {
                { "date_of_sending_notification","test data"},
                { "notification_for_user","test data"}
            };

            try
            {
                Console.WriteLine("-------Client 1---------");

                using (var client = new MyGovClient1())
                {
                    var results = await client.GetTasks();

                    if (results.Length > 0)
                    {
                        var result = await client.GetTask(results[0].id);
                        var response1 = await client.Update(results[0].id, ActionList.AcceptForm, values);
                        var response2 = await client.Update(results[0].id, ActionList.RejectApplication, values);

                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine("Tasks is empty");
                    }
                }

            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            finally
            {
                Console.WriteLine("------------------------");
                Console.WriteLine();
            }

            try
            {
                Console.WriteLine("-------Client 2---------");

                using (var client = new MyGovClient2())
                {
                    var results = await client.GetTasks();

                    if (results.Length > 0)
                    {
                        var result = await client.GetTask(results[0].id);
                        var response1 = await client.Update(results[0].id, ActionList.AcceptFormOfReceivingStatusBroker,values);
                        var response2 = await client.Update(results[0].id, ActionList.RejectFormOfReceivingStatusBroker,values);

                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine("Tasks is empty");
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            finally
            {
                Console.WriteLine("------------------------");
                Console.WriteLine();
            }

            try
            {
                Console.WriteLine("-------Client 3---------");

                using (var client = new MyGovClient3())
                {
                    var results = await client.GetTasks();

                    if (results.Length > 0)
                    {
                        var result = await client.GetTask(results[0].id);
                        var response1 = await client.Update(results[0].id, ActionList.AcceptForm, values);
                        var response2 = await client.Update(results[0].id, ActionList.RejectApplication, values);
                    }
                    else
                    {
                        Console.WriteLine("Tasks is empty");
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            finally
            {
                Console.WriteLine("------------------------");
                Console.WriteLine();
            }
        }

    }
}
