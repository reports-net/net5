using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace PaoWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();

                    // シンプルなDockerFileをビルド手法で他の環境において動作させる時
                    // ポートを80から変更するときにコメントアウトて、お好みのポートを指定してください。
                    //webBuilder.UseUrls("http://0.0.0.0:5000");  // ADD IMPORTANT !!


                    // シンプルなDockerFileビルドでAWSやGCPその他環境で動作させる手法については、
                    // 次のURLの動画を参考にされてください。基本的には同じ手順です。
                    // AWS-EC2で動作(.NET5) https://youtu.be/0y3K3CW7DRM
                    // AWS-EC2で動作(.NET6) https://youtu.be/UnPXcadLwFY
                    // GCPで動作 https://youtu.be/0y3K3CW7DRM

                });

    }
}
