const express = require('express');
router = express.Router();


router.get('/', (req, res) => {
  res.json('Hello world!');
});

router.get('/product', (req, res) => {
  res.json('Product by Node!');
});

router.get('/item', (req, res) => {
  res.json('Hello Item!');
});
module.exports = router;
