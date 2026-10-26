import 'dotenv/config'
import express from 'express'
import { MongoClient } from 'mongodb'

const app = express()
const client = new MongoClient(process.env.MONGO_URI)

client.connect().then(() => {

    const db = client.db('bancodedados')
    const teste = db.collection('teste')

    app.listen(3000)
})