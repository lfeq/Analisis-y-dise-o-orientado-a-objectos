const Demon = require('../models/demon');

module.exports = {
  register(req, res) {
    console.log(req.body);
    const demon = req.body;
    const filePath = req.file ? req.file.path : null;

    demon.file_path = filePath;

    Demon.create(demon, (err, data) => {
      if (err) {
        return res.status(501).json({
          success: false,
          message: 'Todo se fue al demonio',
          error: err,
        });
      }
      return res.status(201).json({
        success: true,
        message: 'Todo salio de poca madre',
        data: data,
      });
    });
  },
};
