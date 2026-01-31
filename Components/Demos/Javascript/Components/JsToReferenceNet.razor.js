export function callreferencenetfromjs (dotNetHelper) {
    return dotNetHelper.invokeMethodAsync('GetHelloMessage', 'Blazor');
};


window.callnetfromjs = () => {
    
    DotNet.invokeMethodAsync('DependencyInjectionDemo', 'NameOfTheMethod').
        then(data => {
            document.getElementById("StaticResultId").innerText = data;
        });
}