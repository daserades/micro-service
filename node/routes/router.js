const express = require('express');
const comment = require('../comment/comment.js');
router = express.Router();

router.get('/', (req, res) => {
  comment.GetAll(req,res);
});

router.get('/:id', (req, res) => {
  comment.GetOne(req,res);
});

module.exports = router;
