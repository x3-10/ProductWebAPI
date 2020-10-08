var mysql = require('SQLEXPRESS');

var con = mysql.createConnection({
    host: "SQLEXPRESS",
    user: "ACT-Student",
    password: ""
});

con.connect(function (err) {
    if (err) throw err;
    console.log("Connected!");
});