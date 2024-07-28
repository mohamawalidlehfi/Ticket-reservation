$(function () {
    $("#inputCheckIn").datepicker();
    $("#inputCheckOut").datepicker();

  });
  $('.level-slider-1').slick({
    centerMode: true,
    centerPadding: '60px',
    slidesToShow: 3,
    responsive: [
      {
        breakpoint: 768,
        settings: {
          arrows: false,
          centerMode: true,
          centerPadding: '40px',
          slidesToShow: 3
        }
      },
      {
        breakpoint: 480,
        settings: {
          arrows: false,
          centerMode: true,
          centerPadding: '40px',
          slidesToShow: 1
        }
      }
    ]
  });
  $('.level-slider-2').slick({
    centerMode: true,
    centerPadding: '60px',
    slidesToShow: 3,
    responsive: [
      {
        breakpoint: 768,
        settings: {
          arrows: false,
          centerMode: true,
          centerPadding: '40px',
          slidesToShow: 3
        }
      },
      {
        breakpoint: 480,
        settings: {
          arrows: false,
          centerMode: true,
          centerPadding: '40px',
          slidesToShow: 1
        }
      }
    ]
  });
  const forms = document.querySelector(".forms"),
  pwShowHide = document.querySelectorAll(".eye-icon"),
  links = document.querySelectorAll(".link");

pwShowHide.forEach(eyeIcon => {
eyeIcon.addEventListener("click", () => {
    let pwFields = eyeIcon.parentElement.parentElement.querySelectorAll(".password");
    
    pwFields.forEach(password => {
        if(password.type === "password"){
            password.type = "text";
            eyeIcon.classList.replace("bx-hide", "bx-show");
            return;
        }
        password.type = "password";
        eyeIcon.classList.replace("bx-show", "bx-hide");
    })
    
})
})      

links.forEach(link => {
link.addEventListener("click", e => {
   e.preventDefault(); 
   forms.classList.toggle("show-signup");
})
})
function redirectGirişYap() {
    window.location.href = "loginPaga";

}
function redirectkayol() {
    window.location.href = "signpPaga";

}
function redirectCheck() {
    window.location.href = "Cart";

}

document.addEventListener("DOMContentLoaded", function () {
    const prices = {
        "Atatürk International Airport":{
            "Sabih Gökçen International Airport": 50,
            "Ankara Esenboga Airport": 70,
            "Antalya Airport": 80,
            "Izmir Adnan Menderes Airport": 90,
            "Dalaman Airport": 100,
            "Bodrum Milas Airport": 110,
            "Trabzon Airport": 120,
            "Diyarbakir Airport": 130,
            "Gaziantep Airport": 140,
            "Van Ferit Melen Airport": 150, 
            "Adana Sakirpasa Airport": 160,
            "Konya Airport": 170
        },
        "Sabih Gökçen International Airport": {
            "Atatürk International Airport": 50,
            "Ankara Esenboga Airport": 60,
            "Antalya Airport": 90,
            "Izmir Adnan Menderes Airport": 100,
            "Dalaman Airport": 110,
            "Bodrum Milas Airport": 120,
            "Trabzon Airport": 130,
            "Diyarbakir Airport": 140,
            "Gaziantep Airport": 150,
            "Van Ferit Melen Airport": 160,
            "Adana Sakirpasa Airport": 170,
            "Konya Airport": 180
        },
        
    };

  const fromAirportSelect = document.getElementById("from-airport");
  const toAirportSelect = document.getElementById("to-airport");
  const totalInput = document.getElementById("total");

  function updatePrice() {
    const fromAirport = fromAirportSelect.value;
    const toAirport = toAirportSelect.value;
    
    if (fromAirport && toAirport && prices[fromAirport] && prices[fromAirport][toAirport] !== undefined) {
        totalInput.value = prices[fromAirport][toAirport] + "TR";
    } 
  }
    document.getElementById("from-airport").addEventListener("change", calculateTotal);
    document.getElementById("to-airport").addEventListener("change", calculateTotal);
});