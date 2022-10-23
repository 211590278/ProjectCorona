var arrMembers=[
    {
        "firstName": "aa",
        "lastName": "ss",
        "address": "addres",
        "dateOfBirth": "2020-01-01T00:00:00",
        "phone": 12346555,
        "mobilePhone": 147852369,
        "idMember": 12
    }]

const homePage=document.getElementById("homePage");

function addToListMember(){
    windowAddMember='Member.html';
    window.location.href = windowAddMember;
    for(var i=0; i<arrMembers.length ;i++){
        document.getElementById("tbodyMember").innerHTML+="<tr><td>"+
        arrMembers[i].firstName +" " +arrMembers[i].firstName+"</td><td>"+
        arrMembers[i].idMember+"</td><td>"+
        `<input type=button value=delet></td><td>
        <input type=button value=update></td><td>
        <input type=button value=details></td></tr>`
        }
}
homePage.addEventListener('click', addToListMember);




const idMember=document.getElementById("idMember");
const firstName=document.getElementById("firstName")
const lastName=document.getElementById("lastName")
const adressCity=document.getElementById("adressCity")
const adressStreet=document.getElementById("adressStreet")
const adressHNunber=document.getElementById("adressHNunber")
const dateOfBirth=document.getElementById("idMember")
const phone=document.getElementById("phone")
const mobilePhone=document.getElementById("mobilePhone")
const submit=document.getElementById("submit");
const memberNew=document.getElementById("memberNew");

function newMember(){
for (let i = 0; i < arrMembers.length; i++) {
    //arr1 = JSON.parse(str);
    var add=adressCity.value;
    add+=adressStreet.value;
    add += adressHNunber.value;
//     idMember.value = arrMembers[i].idMember;
//     firstName.value = arrMembers[i].firstName;
//    adressCity.value+=arrMembers[i].address;
//    adressStreet.value+=arrMembers[i].address;
//    adressHNunber.value+= arrMembers[i].address;
//     idMember.value = arrMembers[i].idMember;
//     dateOfBirth.value = arrMembers[i].dateOfBirth;
//     phone.value = arrMembers[i].phone;
//     mobilePhone.value = arrMembers[i].mobilePhone;
//     memberNew.innerHTML+=arrMembers[i].idMember;
    var newM = new XMLHttpRequest();
    newM.open("POST", yourUrl, true);
    newM.setRequestHeader('Content-Type', 'application/json');
    newM.send(JSON.stringify({
    value: {
        idMember:idMember.value ,
          firstName:firstName.value ,
          lastName:lastName.value, 
          address:add,
           idMember:idMember.value ,
          dateOfBirth:dateOfBirth.value ,
            phone:phone.value ,
            mobilePhone:mobilePhone.value 
          //  memberNew.innerHTML+=arrMembers[i].idMember;
    }
}));
}
}
 submit.addEventListener('click', newMember);


