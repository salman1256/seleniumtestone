pipeline {
    agent any

    stages {
        stage('Checkout Code') {
            steps {
                git 'https://github.com/salman1256/seleniumtestone.git'
            }
        }

        stage('Restore Dependencies') {
            steps {
                sh 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                sh 'dotnet build'
            }
        }

        stage('Run Selenium Tests') {
            steps {
                sh 'dotnet test'
            }
        }

        stage('Publish Test Results') {
            steps {
                junit '**/TestResults/*.xml'  // Works if you install NUnit or XUnit plugin
            }
        }
    }
}
