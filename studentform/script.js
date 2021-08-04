let studentList = [{ fullName: "Pavan", gender: "male", dob: "20/09/1999", email: "pavany@gislen.com", address: "Narsapuram" }, { fullName: "Spandu", gender: "female", email: "spandu@gmail.com", dob: "13/04/2001", address: "Narsapur" }];

class StudentDetail {
    constructor(fullName, isMale, dob, address) {
        this.fullName = fullName
        this.gender = isMale ? 'male' : 'female'
        this.dob = dob
        this.email = email
        this.address = address
    }
}

function StudentInformation() {
    const fullName = document.getElementById("fullName").value;

    const isMale = document.getElementById("gender").checked;

    const dob = document.getElementById("dob").value;

    const email = document.getElementById("email").value;

    const address = document.getElementById('address').value;

    const temp = new StudentDetail(fullName, isMale, dob, address);

    if (temp) {
        studentList.push(temp)

    }
    localStorage.setItem('studentlist', JSON.stringify(studentList))
}

function DisplayDetails() {

    let count = 0;
    const displayStudentTag = document.getElementById("student")
    for (let student of studentList) {

        displayStudentTag.insertAdjacentHTML(tag)
    }
}