pipeline{
    agent any
    stages{
        stage("Tooling versions"){
            steps{
                sh """
                docker --version
                docker-compose version
                """
            }
        }
    }
}