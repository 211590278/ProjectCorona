var arrMembers = [
    {
        "firstName": "aa",
        "lastName": "ss",
        "address": "addres",
        "dateOfBirth": "2020-01-01T00:00:00",
        "phone": 12346555,
        "mobilePhone": 147852369,
        "idMember": 12
    },
    {
        "firstName": "b",
        "lastName": "s",
        "address": "ad",
        "dateOfBirth": "2020-01-01T00:00:00",
        "phone": 12555,
        "mobilePhone": 852369,
        "idMember": 34
    },
    {
        "firstName": "c",
        "lastName": "d",
        "address": "es",
        "dateOfBirth": "2020-01-01T00:00:00",
        "phone": 12345,
        "mobilePhone": 1452369,
        "idMember": 56
    }]
const dMember = document.getElementById("dMember");
function detailsMember(i) {

    //ind = e.currentTarget.index;
    dMember.innerHTML += arrMembers[i].idMember;
    dMember.innerHTML += arrMembers[i].firstName;
    dMember.innerHTML += arrMembers[i].lastName;
    dMember.innerHTML += arrMembers[i].address;
    dMember.innerHTML += arrMembers[i].dateOfBirth;
    dMember.innerHTML += arrMembers[i].phone;
    dMember.innerHTML += arrMembers[i].mobilePhone;

}
function deleleMember(i) {
    arrMembers[i].splice(i, 1);
}
function updateMember(i) {
    var add = adressCity.value;
    add += adressStreet.value;
    add += adressHNunber.value;
    var updateM = new XMLHttpRequest();
    updateM.open("PUT", 'https://localhost:44393/api/corona/UpdateMember', true);
    updateM.setRequestHeader('Content-Type', 'application/json');
    updateM.send(JSON.stringify({
        value: {
            firstName: firstName.value,
            lastName: lastName.value,
            address: add,
            idMember: idMember.value,
            phone: phone.value,
            mobilePhone: mobilePhone.value
        }
    }));
}


window.onload = function () {
    const req = new XMLHttpRequest();
    req.onreadystatechange = function () {
        if (req.readyState == XMLHttpRequest.DONE) {
            alert(req.response);

        }
    }
    req.open("GET", 'https://localhost:44393/api/corona/GetAllMember');

    req.send();
    for (var i = 0; i < arrMembers.length; i++) {
        document.getElementById("tbodyMember").innerHTML += "<tr id=someList ><td>" +
            arrMembers[i].firstName + " " + arrMembers[i].firstName + "</td><td>" +
            arrMembers[i].idMember + "</td><td>" +
            `<input type=button onclick="deleleMember(`+ i +`)" value=delet></td><td>
<input type=button onclick="updateMember(`+ i + `)"  value=update></td><td>
<input type=button  onclick="detailsMember(`+ i + `)" value=details></td></tr>`
    }
};



    












// function addMember() {
//     windowAddMember='AddMember.html';
//     window.location.href = windowAddMember;
// }
// addmember.addEventListener('click', addMember);

