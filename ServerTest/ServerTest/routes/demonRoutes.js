const demonsController = require('../controllers/demonController');
const multer = require('multer');
const path = require('path');

// Configura la carpeta donde se guardarán los archivos
const storage = multer.diskStorage({
    destination: (req, file, cb) => {
      cb(null, 'uploads/'); // Carpeta donde se guardarán los archivos
    },
    filename: (req, file, cb) => {
      const fileName = Date.now() + path.extname(file.originalname);
      cb(null, fileName);
    },
  });
  
const upload = multer({ storage: storage });

module.exports = (app) => {
    app.post('/api/demon/create', demonsController.register);
}