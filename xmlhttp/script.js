let data = [];

function GetData() {
    var request = new XMLHttpRequest();


    request.addEventListener('onreadystatechange') {


        if (this.readyState === 4 && this.status == 200) {
            const response = JSON.parse(this.responseText)
            this.data = response
            for (let employee of response.data) {
                AddElementToHTML(employee)
            }
        }
    }

    request.open('GET', 'https://reqres.in/api/users?page=1')
    request.send();
}