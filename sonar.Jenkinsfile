node {
  stage('SCM') {
    checkout scm
  }
  stage('SonarQube Analysis') {
    def scannerHome = tool 'SonarScanner for MSBuild'
    withSonarQubeEnv() {
      sh "/usr/local/bin/dotnet ${scannerHome}/SonarScanner.MSBuild.dll begin /k:\"hello-devops-project\""
      sh "/usr/local/bin/dotnet build"
      sh "/usr/local/bin/dotnet ${scannerHome}/SonarScanner.MSBuild.dll end"
    }
  }
}
