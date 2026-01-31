export function callreferencenetfromjs (dotNetHelper) {
    return dotNetHelper.invokeMethodAsync('GetHelloMessage', 'Blazor');
};