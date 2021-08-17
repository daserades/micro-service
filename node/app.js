const express = require('express')
const router = require('./routes/router');
const app = express()
const port = 3030


app.use('/node/', router);

app.listen(port, () => {
  console.log(`Example app listening at http://localhost:${port}`)
})