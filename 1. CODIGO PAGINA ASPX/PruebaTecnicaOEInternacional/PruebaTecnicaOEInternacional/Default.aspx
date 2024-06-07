<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PruebaTecnicaOEInternacional._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="row" style="min-height: calc(100vh - 150px)">
            <section class="col-12 d-flex flex-column justify-content-center align-items-center" aria-labelledby="gettingStartedTitle">
                <div class="card">
                    <div class="card-body px-4 py-4">
                        <div class="d-flex flex-column justify-content-center">
                            <div class="mb-3">
                                <asp:Label
                                    for="username"
                                    class="form-label"
                                    runat="server">
                                    Usuario
                                </asp:Label>
                                <asp:TextBox
                                    ID="username"
                                    type="text"
                                    class="form-control"
                                    placeholder="Ingrese el usuario"
                                    runat="server" />
                                <asp:RequiredFieldValidator
                                    ID="rfvUsername"
                                    ControlToValidate="username"
                                    ForeColor="Red"
                                    runat="server">
                                    * Por favor, ingrese su nombre de usuario.
                                </asp:RequiredFieldValidator>
                            </div>
                            <div class="mb-3">
                                <asp:Label
                                    for="password"
                                    class="form-label"
                                    runat="server">
                                    Contraseña
                                </asp:Label>
                                <asp:TextBox
                                    ID="password"
                                    type="password"
                                    class="form-control"
                                    placeholder="Ingrese la contraseña"
                                    runat="server" />
                                <asp:RequiredFieldValidator
                                    ID="rfvPassword"
                                    runat="server"
                                    ControlToValidate="password"
                                    ForeColor="Red">
                                    * Por favor, ingrese su contraseña.
                                </asp:RequiredFieldValidator>
                            </div>
                            <button class="btn btn-success">Ingresar</button>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </main>

</asp:Content>
