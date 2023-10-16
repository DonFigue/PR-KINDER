<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentCreate.aspx.cs" Inherits="LaCasitaDeFreireWeb.Pages.Student.StudentCreate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

   <form runat="server" id="form">
     <div class="card bg-dark text-white">
        <div class="card-header">
            <h3>Students</h3>
        </div>
        <div class="card-body">
            <div>
                <div>
                        <div asp-validation-summary="ModelOnly" class="text-danger"></div>
                       <div class="card-body">
                            <div class="row">
                                <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="StudentCode" class="control-label">Código de estudiante</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtCode"  />
                                        <asp:Label ID="lblCodeError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                            
                                        </div>
                                    </div>
                                 <div class="col-md-6">
                                       <div class="form-group">
                                         <label for="FirstName" class="control-label">First Name</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtFirstName"  />
                                        <asp:Label ID="lblNameError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                       
                                           </div>
                                  </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="LastName" class="control-label">Last Name</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtLastName"  />
                                        <asp:Label ID="lblApellidoError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                        
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="SecondLastName" class="control-label">Second Last Name</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtSecondLastName"  />
                                        <asp:Label ID="lblSegError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                        
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="Ci" class="control-label">CI</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtCI"  />
                                        <asp:Label ID="lblCiError" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                       
                                            </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="Address" class="control-label">Address</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtAddress"  />
                                        <asp:Label ID="lblAddress" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                       
                                            </div>
                                    </div>
                                     <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="Discapacity" class="control-label">Discapacidad</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtDiscapacity"  />
                                        <asp:Label ID="lblDiscapacity" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                       
                                            </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="BirthDate" class="control-label">BirthDate</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtBirthDate" TextMode="Date"  />
                                        <asp:Label ID="lblBirthdate" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                      
                                            </div>
                                    </div>
                                        <p> </p>
                                
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            

                                            <asp:RadioButtonList ID="rdbGender" runat="server" CssClass="form-control">
                                                <asp:ListItem Text="Masculino" Value="M" />
                                                <asp:ListItem Text="Femenino" Value="F" />
                                                <asp:ListItem Text="Otro" Value="O" Selected="True" />
                                            </asp:RadioButtonList>
                                        <asp:Label ID="lblGenero" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                       
                                            </div>
                                    </div>
                                 <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="PlaceBirth" class="control-label">Place of Birth</label>
                                           <asp:TextBox runat="server" CssClass="form-control" ID="txtPlaceOfBirth"  />
                                        <asp:Label ID="lblPlaceBirth" runat="server" CssClass="error-message" style="color: red;" Visible="false"></asp:Label>
                                       
                                            </div>
                                     </div>
                                </div>
                                    </div>
                                        <div class="d-grid gap-2">
                                        </div>
                               
                            </div>
                        </div>
        <div class="container">
  <div class="row">
    <div class="col-12 d-flex justify-content-center">
      <div class="card">
          <div class="card-header text-center bg-success">
              <h3>Pagos</h3>
          </div>
          <div class="card-body bg-dark text-white text-center">
                                            
                    <label for="TotalAmount" class="control-label">Total</label>
              <asp:TextBox runat="server" ID="txtTotalAmount" CssClass="form-control" oninput="updateTotalAmount()"></asp:TextBox>
                <%--<label for="OFf" class="control-label" >Descuento</label>
                <asp:TextBox runat="server" ID="txtOff" CssClass="form-control" oninput="Off()"></asp:TextBox>--%>
            <%--<asp:Label runat="server" ID="lblAmount" CssClass="card-title text-danger fs-2 text-center">Total de 6000 Bs.</asp:Label>--%>
              <p class="card-subtitle mb-2 text-secondary">Personalice el plan de pagos. (Minimo 1 - Maximo 12)</p>
              <p class="card-subtitle mb-2 text-secondary">El total se divide entre la cantidad de pagos.</p>
              <div class="form-group">
                <label for="Quantity" class="control-label">Cantidad de Pagos</label>
                  <asp:HiddenField ID="hdnPreviousValue" runat="server" Value="1" />

                <asp:TextBox runat="server" CssClass="form-control" ID="txtQuantityOfPayments" TextMode="Number" oninput="updatePaymentDetail();">1</asp:TextBox>
                <asp:Label ID="lblQuantityOfPayments" runat="server" CssClass="error-message" style="color: red;" Visible="false" ></asp:Label>

            </div>
          </div>
          <div class="card-footer bg-secondary text-center">
              <asp:Label runat="server" ID="PaymentDetail" CssClass="lead fs-5"></asp:Label>
          </div>
       
      </div>
    </div>
  </div>
</div>
    </div>

         
        <div class="card-footer bg-dark text-white">
            <div class="d-grid gap-2">
                <asp:Button runat="server" ID="btnUpdate" Text="Save Changes" CssClass="btn btn-outline-success" OnClick="btnInsert_Click" />
                <a class="btn btn-outline-secondary" href="#">Cancel</a>
            </div>
        </div>
   </form>
    
    <script type="text/javascript">
        function updatePaymentDetail() {
            var txtQuantityOfPayments = document.getElementById('<%= txtQuantityOfPayments.ClientID %>');
            var hdnPreviousValue = document.getElementById('<%= hdnPreviousValue.ClientID %>');
            var paymentDetailLabel = document.getElementById('<%= PaymentDetail.ClientID %>');
            var btn = document.getElementById('<%= btnUpdate.ClientID %>');
            var txttotal = document.getElementById('<%= txtTotalAmount.ClientID %>');
            var amount = txttotal.value;
            var newValue = txtQuantityOfPayments.value;
            var previousValue = hdnPreviousValue.value;
            if (newValue > 12) {
                newValue = 12;
                paymentDetailLabel.textContent = "Solo se puede tener 12 cuotas como maximo.";
                btn.disabled = true;

            }
            else if (newValue <1) {
                newValue = 1;
                paymentDetailLabel.textContent = "Ingrese un valor valido";
                btn.disabled = true;
                btn.textContent = "Errpr";
            }
            else {
                txtQuantityOfPayments.textContent = Math.round(newValue);
                btn.disabled = false;
                var total = amount / newValue;

                if (newValue !== previousValue) {
                    // Actualiza el texto del asp:Label
                    paymentDetailLabel.textContent = total + "Bs. en cada pago";
                    // Actualiza el valor del HiddenField con el nuevo valor
                    hdnPreviousValue.value = newValue;
                }
            }
            
        }
        function updateTotalAmount() {
            var txtQuantityOfPayments = document.getElementById('<%= txtTotalAmount.ClientID %>');
            var btn = document.getElementById('<%= btnUpdate.ClientID %>');
            var paymentDetailLabel = document.getElementById('<%= PaymentDetail.ClientID %>');

            var newValue = txtQuantityOfPayments.value;
            if (newValue == 0) {
                

                btn.disabled = true;
                paymentDetailLabel.textContent = "El total no puede ser 0.";

            }
            else if (newValue < 0) {
                newValue = 1;
                btn.disabled = true;
                btn.textContent = "Err0r";
                paymentDetailLabel.textContent = "Ingrese un valor valido mayor a 0";
           }
            else {
                txtQuantityOfPayments.textContent = Math.round(newValue);
                btn.disabled = false;
                var total = 6000 / newValue;

                if (newValue !== previousValue) {
                    // Actualiza el texto del asp:Label
                    // Actualiza el valor del HiddenField con el nuevo valor
                    paymentDetailLabel.textContent = "";
                    hdnPreviousValue.value = newValue;
                }
            }

        }
    </script>
</asp:Content>

