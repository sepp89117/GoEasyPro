Public Class browseForm
    Private Sub browseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '        WebBrowser1.DocumentText = String.Format("<!DOCTYPE html>
        '<html>
        '    <head>
        '        <meta http-equiv='Content-Type' content='text/html; charset=unicode' />
        '        <meta http-equiv='X-UA-Compatible' content='IE=9' /> 
        '        <title></title>
        '    </head>
        '    <body>
        '        <div>
        '            <video width=""640"" height=""360"" src=""{0}"" controls>
        '            </video>
        '        </div>
        '    </body>
        '</html>", Form1.videoUrl)

        '        WebBrowser1.DocumentText = String.Format("<html>
        '<title>VLC plugin test page</title>
        '<body>
        '<embed type=""application/x-vlc-plugin"" pluginspage=""http//www.videolan.org"" version=""VideoLAN.VLCPlugin.2""
        'width=""1280""
        'height=""720""
        'id=""vlc""
        'volume=""25"" />
        '<script>
        'var vlc = document.getElementById(""vlc"");
        'vlc.playlist.add(""{0}"", ""GoPro"");
        'vlc.playlist.play();
        'vlc.video.deinterlace.enable(""blend""); 
        '</script>
        '</body>", Form1.videoUrl)

    End Sub


End Class