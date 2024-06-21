import express, { Request, Response } from 'express';
import bodyParser from 'body-parser';
import fs from 'fs';
import path from 'path';

const app = express();
const PORT = 3000;
const dbPath = path.resolve(__dirname, 'db.json');

app.use(bodyParser.json());

// Endpoint to check server status
app.get('/ping', (req: Request, res: Response) => {
    res.json(true);
});

// Endpoint to submit form data
app.post('/submit', (req: Request, res: Response) => {
    const { name, email, phone, github_link, stopwatch_time } = req.body;
    
    const newSubmission = { name, email, phone, github_link, stopwatch_time };
    
    const data = JSON.parse(fs.readFileSync(dbPath, 'utf-8'));
    data.push(newSubmission);
    fs.writeFileSync(dbPath, JSON.stringify(data, null, 2));
    
    res.json({ message: 'Submission successful' });
});

// Endpoint to read a form submission by index
app.get('/read', (req: Request, res: Response) => {
    const index = parseInt(req.query.index as string, 10);
    
    const data = JSON.parse(fs.readFileSync(dbPath, 'utf-8'));
    
    if (index >= 0 && index < data.length) {
        res.json(data[index]);
    } else {
        res.status(404).json({ error: 'Submission not found' });
    }
});

// Endpoint to delete a submission by index
app.delete('/delete', (req: Request, res: Response) => {
    const index = parseInt(req.query.index as string, 10);
    const data = JSON.parse(fs.readFileSync(dbPath, 'utf-8'));

    if (index >= 0 && index < data.length) {
        data.splice(index, 1);
        fs.writeFileSync(dbPath, JSON.stringify(data, null, 2));
        res.json({ message: 'Deletion successful' });
    } else {
        res.status(404).json({ error: 'Submission not found' });
    }
});

// Endpoint to edit a submission by index
app.put('/edit', (req: Request, res: Response) => {
    const index = parseInt(req.query.index as string, 10);
    const { name, email, phone, github_link, stopwatch_time } = req.body;
    const data = JSON.parse(fs.readFileSync(dbPath, 'utf-8'));

    if (index >= 0 && index < data.length) {
        data[index] = { name, email, phone, github_link, stopwatch_time };
        fs.writeFileSync(dbPath, JSON.stringify(data, null, 2));
        res.json({ message: 'Edit successful' });
    } else {
        res.status(404).json({ error: 'Submission not found' });
    }
});

// Endpoint to search submissions by email
app.get('/search', (req: Request, res: Response) => {
    const email = req.query.email as string;
    const data = JSON.parse(fs.readFileSync(dbPath, 'utf-8'));
    const results = data.filter((submission: any) => submission.email === email);

    res.json(results);
});

app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
});
