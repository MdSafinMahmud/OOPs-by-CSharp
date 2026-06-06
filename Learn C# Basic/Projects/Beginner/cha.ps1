# AetherVoice.ps1
Add-Type -AssemblyName System.Speech
$speech = New-Object System.Speech.Synthesis.SpeechSynthesizer

Write-Host "Aether: Hi! I'm Aether" -ForegroundColor Green
$speech.Speak("Hi, I'm Aether")

Write-Host "What's your name?" -ForegroundColor Yellow
$userName = Read-Host

Write-Host "Aether: Hello $userName" -ForegroundColor Green
$speech.Speak("Hello $userName")

while($true) {
    Write-Host "`nYou: " -ForegroundColor Yellow -NoNewline
    $message = Read-Host
    
    if($message -eq "good bye") {
        Write-Host "Aether: Good bye! Take care" -ForegroundColor Green
        $speech.Speak("Good bye, take care")
        break
    }
    elseif($message -eq "hello" -or $message -eq "hi") {
        Write-Host "Aether: Hi! How can I help you?" -ForegroundColor Green
        $speech.Speak("Hi, how can I help you")
    }
    elseif($message -eq "how are you") {
        Write-Host "Aether: I'm fine, thank you!" -ForegroundColor Green
        $speech.Speak("I'm fine, thank you")
    }
    elseif($message -eq "tell me a joke") {
        Write-Host "Aether: Why do programmers prefer dark mode? Because light attracts bugs!" -ForegroundColor Green
        $speech.Speak("Why do programmers prefer dark mode? Because light attracts bugs")
    }
    else {
        Write-Host "Aether: I don't understand that" -ForegroundColor Green
        $speech.Speak("I don't understand that")
    }
}


#its created by deepsek