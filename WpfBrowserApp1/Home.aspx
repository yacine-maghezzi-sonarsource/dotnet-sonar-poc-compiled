<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">



    <contenttemplate>

        <div class="card-group">
            <div class="card">
                <div class="card-header " style="background-color: white; color: #1D1760; text-align: center; font-variant: normal; font-weight: bold; font-size: 23px; line-height: normal; font-family: Helvetica;"></div>
                <div class="card-body" style="background-color: aliceblue">
                    <%--Step 1 - Retrive Booking --%>
                    <div id="Step1" visible="true" runat="server">
                        <div class="card">
                            <div class="card-header " style="background-color: white; color: gray; font: Bold 18px Helvetica; text-align: center"></div>
                            <div class="card-body  ">

                                <div class="container-fluid ">

                                    <div class="row justify-content-center ">
                                        <div class="col-md-12 col-lg-6 ">
                                        </div>
                                    </div>


                                    <div class="row justify-content-center">

                                        <div class="col-md-12 col-lg-6">
                                            <asp:Button ID="Button1" runat="server" Text="Click Here" CssClass="form-control btn-info" OnClick="Button1_Click" />
                                            <asp:Label ID="Label1" runat="server" Text="" ForeColor="black" Visible="true"></asp:Label>
                                            <br />
                                            <asp:Label ID="Label2" runat="server" Text="" ForeColor="black" Visible="true" ></asp:Label>
                                            <br />
                                            <asp:Label ID="Label3" runat="server" Text="" ForeColor="black" Visible="true" ></asp:Label>
                                            <br />
                                            <asp:Label ID="Label4" runat="server" Text="" ForeColor="black" Visible="true" ></asp:Label>
                                            <br />
                                            <asp:Label ID="Label5" runat="server" Text="" ForeColor="black" Visible="true" ></asp:Label>
                                            <br />
                                            <asp:Label ID="Label6" runat="server" Text="" ForeColor="black" Visible="true" ></asp:Label>
                                            <br />
                                            <asp:Label ID="Label7" runat="server" Text="" ForeColor="black" Visible="true" ></asp:Label>
                                            <br />
                                            <asp:Label ID="Label8" runat="server" Text="" ForeColor="black" Visible="true" ></asp:Label>
                                            <br />
                                            <asp:Label ID="Label9" runat="server" Text="" ForeColor="black" Visible="true" ></asp:Label>
                                            <br />
                                            <asp:Label ID="Label10" runat="server" Text="" ForeColor="black" Visible="true" ></asp:Label>
                                            <br />
                                            <asp:Label ID="Label11" runat="server" Text="" ForeColor="black" Visible="true" ></asp:Label>
                                            <br />
                                            <asp:Label ID="Label12" runat="server" Text="" ForeColor="black" Visible="true" ></asp:Label>
                                            <br />
                                            <asp:Label ID="Label13" runat="server" Text="" ForeColor="black" Visible="true" ></asp:Label>
                                            <br />
                                            <asp:Label ID="Label14" runat="server" Text="" ForeColor="black" Visible="true" ></asp:Label>
                                        </div>

                                    </div>
                                    <br />
                                    <br />

                                </div>

                            </div>
                            <br />
                            <br />
                        </div>
                    </div>
                    <%--==========================--%>

                    <%--==========================--%>
                </div>

            </div>
        </div>

    </contenttemplate>


</asp:Content>
