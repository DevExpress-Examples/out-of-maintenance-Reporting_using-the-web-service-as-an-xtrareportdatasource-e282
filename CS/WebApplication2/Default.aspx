<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v18.2.Web.WebForms, Version=18.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dxwc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dxwc:ReportToolbar ID="ReportToolbar1" runat="server" ReportViewer="<%# ReportViewer1 %>"
            ShowDefaultButtons="False">
            <Items>
                <dxwc:ReportToolbarButton ItemKind="Search" ToolTip="Display the search window" />
                <dxwc:ReportToolbarSeparator />
                <dxwc:ReportToolbarButton ItemKind="PrintReport" ToolTip="Print the report" />
                <dxwc:ReportToolbarButton ItemKind="PrintPage" ToolTip="Print the current page" />
                <dxwc:ReportToolbarSeparator />
                <dxwc:ReportToolbarButton Enabled="False" ItemKind="FirstPage" ToolTip="First Page" />
                <dxwc:ReportToolbarButton Enabled="False" ItemKind="PreviousPage" ToolTip="Previous Page" />
                <dxwc:ReportToolbarLabel Text="Page" />
                <dxwc:ReportToolbarComboBox ItemKind="PageNumber" Width="65px">
                </dxwc:ReportToolbarComboBox>
                <dxwc:ReportToolbarLabel Text="of" />
                <dxwc:ReportToolbarTextBox ItemKind="PageCount" />
                <dxwc:ReportToolbarButton ItemKind="NextPage" ToolTip="Next Page" />
                <dxwc:ReportToolbarButton ItemKind="LastPage" ToolTip="Last Page" />
                <dxwc:ReportToolbarSeparator />
                <dxwc:ReportToolbarButton ItemKind="SaveToDisk" ToolTip="Export a report and save it to the disk" />
                <dxwc:ReportToolbarButton ItemKind="SaveToWindow" ToolTip="Export a report and show it in a new window" />
                <dxwc:ReportToolbarComboBox ItemKind="SaveFormat" Width="70px">
                    <Elements>
                        <dxwc:ListElement Text="Pdf" Value="pdf" />
                        <dxwc:ListElement Text="Xls" Value="xls" />
                        <dxwc:ListElement Text="Rtf" Value="rtf" />
                        <dxwc:ListElement Text="Mht" Value="mht" />
                        <dxwc:ListElement Text="Text" Value="txt" />
                        <dxwc:ListElement Text="Image" Value="png" />
                    </Elements>
                </dxwc:ReportToolbarComboBox>
            </Items>
        </dxwc:ReportToolbar>
        <dxwc:ReportViewer ID="ReportViewer1" runat="server" Height="510px" Width="659px" />
    </div>
    </form>
</body>
</html>
