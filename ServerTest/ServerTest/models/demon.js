const db = require('..config/config');

const Demon ={};

Demon.create = (demon, result) => {
    const sql = `
    INSERT INTO
        demons(
            demon_name,
            zodiac,
            material,
            model
        )
        VALUES(
            Baphy, Capricornio, Peluche, 123
        )
    `;

    db.query(
        sql,[
            demon.demon_name,
            demon.zodiac,
            demon.material,
            demon.model
        ],
        (err, res) => {
            if(err){
                console.log("Error: ", err);
                result(err, null);
            }else{
                console.log('ID del nuevo demonio: ', res.insertId);
            }
        }
    )
}

module.exports = Demon;