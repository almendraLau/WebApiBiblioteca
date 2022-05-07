
    const URL = 'https://localhost:44386/api/Cartillas';

    fetch(URL)
        .then(res => res.json())
        .then(data => {
            console.log(data);
            var div = document.getElementById("div")
            var card = '';
            for (var i = 0; i < data.length; i++) {
                 card += `
                            <div class="card" style="width: 18rem; padding-top=20px;">
                              <img src="..." class="card-img-top" alt="">
                              <div class="card-body">
                                <h5 class="card-title">${data[i].cTitle}</h5>
                                <p class="card-text">${data[i].cDescription}.</p>
                                <a href="${data[i].cLinkButton}" class="btn btn-primary">${data[i].cTextButton}</a>
                              </div>
                            </div>
                            <br>
                            `;
            }
            div.innerHTML = card;
            
        })

document.getElementById("agregar").addEventListener("click", function () {
    var title = document.getElementById('title').value;
    var description = document.getElementById('description').value;
    var photo = document.getElementById('photo').value;
    var textButton = document.getElementById('textButton').value;
    var link = document.getElementById('url').value;

    var url = 'https://localhost:44386/api/Cartillas';

    var data = {
        cTitle: title,
        cDescription: description,
        cPhotography: photo,
        cTextButton: textButton,
        cLinkButton: link
    };

    fetch(url, {
        method: 'POST', // or 'PUT'
        body: JSON.stringify(data), // data can be `string` or {object}!
        headers: {
            'Content-Type': 'application/json'
        }
    }).then(res => res.json())
        .catch(error => console.error('Error:', error))
        .then(alert("Guardado exitosamente."));
});



