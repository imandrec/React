const sampleData = [
    {
        "name": "init",
        "question": "What service do you need",
        "type": "radio",
        "options": {
            "Web Development": "1",
            "App Development": "2",
            "Chatbot": "3"
        }
    },
    {
        "case": "1",
        "question": "Do you need a new website??",
        "type": "text"
    },
    {
        "case": "2",
        "question": "What kind of app do you need??",
        "type": "checkbox",
        "options": {
            "I need to do a game": "1",
            "I need an app for my store": "2",
            "I want an app for my customers": "3"
        }
    },
    {
        "case": "3",
        "question": "What kind of business do you have??",
        "type": "text"
    }
];

export default sampleData;