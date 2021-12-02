window.Console = (message) => {
    console.log(message);
};

window.ShowSwal = (type, message) => {
    if (type === "success") {
        Swal.fire({
            title: "Success Notification",
            text: message,
            icon: type,
            confirmButtonText: 'OK'
        });
    }
    if (type === "error") {
        Swal.fire({
            title: "Error Notification",
            text: message,
            icon: type,
            confirmButtonText: 'OK'
        });
    }

}