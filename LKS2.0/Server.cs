using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace LKS2._0
{
    public static class Server
    {
        static HttpListener server = new HttpListener();
        public static async void Init()
        {
            server.Prefixes.Add("http://127.0.0.1:4201/");
            server.Prefixes.Add("http://localhost:4201/");
            Task.Run(StartServer);
        }

        static Task StartServer()
        {
            server.Start();
            Console.WriteLine("Listening...");
            while(true)
            {
                HttpListenerContext ctx = server.GetContext();
                HttpListenerResponse res = ctx.Response;
                HttpListenerRequest req = ctx.Request;
                string url = req.Url.AbsolutePath;
                string resp = "asdf";
                JavaScriptSerializer serialize = new JavaScriptSerializer();

                if (url == "/menu")
                {
                    List<object> data = new List<object>();
                    foreach (DataSet1.MenuRow row in Database.Data.Menu)
                    {
                        data.Add(new
                        {
                            id = row.menuid,
                            row.name,
                            pic = row.photo,
                            price = $"Rp. {row.price:0,0}"
                        });
                    }
                    var response = new
                    {
                        status = 200,
                        data
                    };
                    resp = serialize.Serialize(response);
                }
                else if(url == "/addReview")
                {
                    if (req.QueryString.Count > 0)
                    {
                        Console.WriteLine(req.Url.Query);
                        DataSet1.MemberRow[] members = Database.Data.Member.Select($@"email='{req.QueryString["member"].ToString()}'") as DataSet1.MemberRow[];
                        Console.WriteLine(members[0].email);
                        if (members.Count() > 0)
                        {
                            DataSet1.MenuRow[] menus = Database.Data.Menu.Select($@"name='{req.QueryString["menuName"].ToString().Replace("%20", " ")}'") as DataSet1.MenuRow[];
                            Console.WriteLine(menus[0].name);
                            if(menus.Count() > 0)
                            {
                                Database.Data.Review.AddReviewRow(members[0], menus[0], req.QueryString["review"], int.Parse(req.QueryString["rating"]));
                                Database.Transact(Database.Data.Review);
                                Database.Commit();
                                var response = new
                                {
                                    status = 200,
                                    data = "Review Berhasil Ditambahkan"
                                };
                                resp = serialize.Serialize(response);
                            }
                            else
                            {
                                var response = new { status = 404, data = "Menu Tidak Ditemukan" };
                                resp = serialize.Serialize(response);
                            }
                        }
                        else
                        {
                            var response = new
                            {
                                status = 404,
                                data = "Email tidak ditemukan"
                            };
                            resp = serialize.Serialize(response);
                        }
                    }
                }
                else if(url == "/reviews")
                {
                    List<object> data = new List<object>();
                    foreach (DataSet1.ReviewRow row in Database.Data.Review)
                    {
                        data.Add(new
                        {
                            memberName = row.MemberRow.name,
                            menuName = row.MenuRow.name,
                            row.review,
                            row.rating
                        });
                    }
                    var response = new
                    {
                        status = 200,
                        data
                    };
                    resp = serialize.Serialize(response);
                }
                byte[] buffer = Encoding.UTF8.GetBytes(resp);
                res.ContentLength64 = buffer.Length;
                Stream stream = res.OutputStream;
                stream.Write(buffer, 0, buffer.Length);
                res.Close();
            }
        }

    }
}
