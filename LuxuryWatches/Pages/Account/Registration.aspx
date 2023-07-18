<%@ Page Title="Đăng Ký" Language="C#"  AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="LuxuryWatches.Pages.Account.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link rel="stylesheet" href="/css/stylere.css"/>
    <title></title>
     <style type="text/css">
         .Btnlg {
             width: 141px;
         }
     </style>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            
            <div class="box">
                <div class="container">
                    <div class="form">
                        <h2>Đăng Ký</h2>
                        <div class="inputbox">
                            <input id="txtTaikhoan" runat="server"   class="style" placeholder="Nhập họ tên"/>
                           
                        </div>

                        <div class="inputbox">
                             <input id="txtEmail"  runat="server" class="style" placeholder="Nhập email"/>
                        </div>

                        <div class="inputbox">
                             <input id="txtSDT"  runat="server" class="style" placeholder="Số điện thoại"/>

                        </div>
                        <div class="inputbox">
  
                        <input id="txtMatkhau" type="Password"  runat="server" class="style" placeholder="Mật khẩu" />

                         </div>

                     

                        <div class="Btnsubmit">
                          <asp:Button ID="btnRegister2" type="submit"  runat="server" ValidationGroup="registerForm" Text="Đăng Ký" OnClick="btnDK_Click"/>
                            
                        </div>
                        <div class="Btnlg">
                            <a style="text-decoration: none" href="/dang-nhap">Đăng Nhập</a>
                        </div>
                    </div>
                </div>
            </div>
           
        </section>
    </form>
</body>
</html>
