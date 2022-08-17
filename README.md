# CMPG-323-Overview-34956905
## Repositorie
For the duration of this semester i will complete all five projects using one repositary.Testing each project using development branches before pushing the final updated version. By doing so I will use a basic folder structure to seperate the diffrent projects from each other

graph LR
id1[(fa:fa-database raw data)] -->|pre-processing| B(data for modelling)
    B --> C{fa:fa-chart-bar models}
    C --> D[Linear Regression]
    C --> E[Random Forest]
    C --> F[KNN]
    D --> G[ensemble]
    E --> G
    F --> G
    G --> id2[(predictions)]
