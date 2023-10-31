<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LaCasitaDeFreireWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div id="myCarousel" class="carousel slide mb-6" data-bs-ride="carousel">
            <div class="carousel-indicators ">
                <button type="button" data-bs-target="#myCarousel" data-bs-slide-to="0" class="" aria-label="Slide 1"></button>
                <button type="button" data-bs-target="#myCarousel" data-bs-slide-to="1" aria-label="Slide 2" class=""></button>
                <button type="button" data-bs-target="#myCarousel" data-bs-slide-to="2" aria-label="Slide 3" class="active" aria-current="true"></button>
            </div>
            <div class="carousel-inner fondo-carousel">
                <div class="carousel-item">
                    <img src="dist/img/kids.jpg" width="1500" height="550" />

                    <div class="container">
                        <div class="carousel-caption text-start">
                        </div>
                    </div>
                </div>
                <div class="carousel-item">
                    <img src="dist/img/festival.jpg" width="1500" height="550" />

                    <div class="container">
                        <div class="carousel-caption">
                        </div>
                    </div>
                </div>
                <div class="carousel-item active">
                    <img src="dist/img/kindergarden.jpg" width="1500" height="550" />

                    <div class="container">
                        <div class="carousel-caption text-end">
                        </div>
                    </div>
                </div>
            </div>
            <button class="carousel-control-prev" type="button" data-bs-target="#myCarousel" data-bs-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Previous</span>
            </button>
            <button class="carousel-control-next" type="button" data-bs-target="#myCarousel" data-bs-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Next</span>
            </button>
        </div>
        <hr class="featurette-divider">
        <!-- ... El resto de tu contenido ... -->
          <div class="container marketing container-marketing">
        <div class="row">

            <div class="col-lg-4">
                <div class="circle-container">
                <img src="dist/img/person1.jpg" alt="Imagen 1" class="img-fluid rounded-circle">
                </div>
                <p> </p>
                <h2 style="color: black;" class="fw-normal">Heading</h2>
                <p style="color: black;">Some representative placeholder content for the three columns of text below the carousel. This is the first column.</p>
            </div>

            <div class="col-lg-4">
                <div class="circle-container">
                <img src="dist/img/person2.jpg" alt="Imagen 1" class="img-fluid rounded-circle">
                </div>
                <p> </p>
                <h2 style="color: black;" class="fw-normal">Heading</h2>
                <p style="color: black;">Another exciting bit of representative placeholder content. This time, we've moved on to the second column.</p>
            </div>

            <div class="col-lg-4">
                    <div class="circle-container">
                <img src="dist/img/person3.jpg" alt="Imagen 1" class="img-fluid rounded-circle">
                </div>
                <p> </p>
                <h2 style="color: black;" class="fw-normal">Heading</h2>
                <p style="color: black;">And lastly this, the third column of representative placeholder content.</p>
            </div>
        </div>
        

        <hr class="featurette-divider">

                <div class="col-lg-6 col-md-8 mx-auto">
                    <div class="bg-custom">
                        <h1 class="fw-light ">NEW SECTION!</h1>
                        <p class="lead text-body-secondary mt-3">
                             Look at our new news section where you can find many interesting things for you
                         </p>
                     </div>
                </div>
      <hr class="featurette-divider" />
        <div class="container">

            <div class="row row-cols-1 row-cols-sm-2 row-cols-md-3 g-3">
                <div class="col">
                    <div class="card shadow-sm">
                        <img src="dist/img/spellingbee.png" class="img-fluid">

                        <div class="card-body">
                            <h4>Spelling Bee</h4>

                            <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                            <div class="d-flex justify-content-between align-items-center">
                                
                                <small class="text-body-secondary">9 mins</small>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col">
                    <div class="card shadow-sm">
                        <img src="dist/img/festivalseptember.jpg" class="img-fluid">

                        <div class="card-body">
                            <h4>Festival September 14</h4>

                            <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                            <div class="d-flex justify-content-between align-items-center">
                                
                                <small class="text-body-secondary">9 mins</small>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col">
                    <div class="card shadow-sm">
                        <img src="dist/img/talentshow.jpg" class="img-fluid">

                        <div class="card-body">
                            <h4>Talent Show</h4>

                            <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                            <div class="d-flex justify-content-between align-items-center">
                                
                                <small class="text-body-secondary">9 mins</small>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </div>
</asp:Content>
