document.addEventListener('DOMContentLoaded', function () {
    var anioActual = new Date().getFullYear();
    var anioMax = anioActual - 1;
    document.getElementById('anioFabricacion').setAttribute('max', anioMax);
});

function generarCotizacion() {
    const anioActual = new Date().getFullYear();
    const costoAuto = parseFloat(document.getElementById('costoAuto').value);
    const anioFabricacion = parseInt(document.getElementById('anioFabricacion').value);

    if (isNaN(costoAuto) || isNaN(anioFabricacion)) {
        alert('Por favor, complete todos los campos.');
        return;
    }

    if (anioFabricacion >= anioActual) {
        alert('El año de fabricación no puede ser mayor al año actual.');
        return;
    }

    const precio = costoAuto / (anioActual - anioFabricacion) * 0.0035;

    document.getElementById('cotizacionId').textContent = parseInt(document.getElementById('ultimaCotizacionId').value) + 1;
    document.getElementById('modalModeloCarro').textContent = document.getElementById('modelo').value;
    document.getElementById('modalAnioFabricacion').textContent = anioFabricacion;
    document.getElementById('modalPrecioCotizacion').textContent = precio.toFixed(2);

    document.getElementById('modalOverlay').style.display = 'block';
    document.getElementById('cotizacionModal').style.display = 'block';
}

function cerrarModal() {
    document.getElementById('cotizacionModal').style.display = 'none';
    document.getElementById('modalOverlay').style.display = 'none';
}

function guardarCotizacion() {
    const form = document.getElementById('crearCotizacionForm');
    form.submit();
}