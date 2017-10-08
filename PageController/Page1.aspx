<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="PageController.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Page-1</title>
</head>
<body>
    <!-- #include virtual="BasePage.inc" -->
      <form id="Page1" method="post" runat="server">
         <h1>Page:
            <asp:label id="pageNumber" Runat="server">NN</asp:label></h1>
      </form>
</body>
</html>


<!-- Notice the line including BasePage.inc aboce. This line ensures the HTML from BasePage.inc gets rendered as a part of
    our current page. We have some predefined behaviour for methods like Page_Load which will execute alongwith page's
    normal life cycle. -->