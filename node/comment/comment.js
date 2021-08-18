const fs = require('fs');
var path = require('path');
const dbPath = path.join(__dirname, '../db/comment.json');
const data = JSON.parse(fs.readFileSync(dbPath, 'utf-8'));

exports.GetAll = GetAll = (req, res) => {
  res.json(data);
};

exports.GetOne = GetOne = (req, res) => {
    res.json(data.filter(e => e.productId == req.params.id));
}
