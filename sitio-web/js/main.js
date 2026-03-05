/* ============================================
   MAIN.JS — Funcionalidades globales
   ============================================ */

// ── Active nav link ──────────────────────────
function setActiveNav() {
  const links = document.querySelectorAll('.nav-link');
  const current = window.location.pathname.split('/').pop() || 'index.html';
  links.forEach(link => {
    const href = link.getAttribute('href');
    if (href && href.includes(current)) {
      link.classList.add('active');
    } else {
      link.classList.remove('active');
    }
  });
}

// ── Scroll fade-in animation ──────────────────
function initScrollAnimations() {
  const elements = document.querySelectorAll('.fade-in-up');
  const observer = new IntersectionObserver((entries) => {
    entries.forEach((entry, i) => {
      if (entry.isIntersecting) {
        setTimeout(() => entry.target.classList.add('visible'), i * 80);
        observer.unobserve(entry.target);
      }
    });
  }, { threshold: 0.1 });
  elements.forEach(el => observer.observe(el));
}

// ── Form validation ───────────────────────────
function initFormValidation() {
  const form = document.getElementById('contactForm');
  if (!form) return;

  // Campos requeridos y sus reglas
  const rules = {
    nombre: {
      test: v => v.trim().length >= 2,
      msg: 'El nombre debe tener al menos 2 caracteres.',
      showValid: false   // ← no mostrar verde
    },
    email: {
      test: v => /^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(v),
      msg: 'Ingresa un correo electrónico válido.',
      showValid: true
    },
    telefono: {
      test: v => /^\d{10}$/.test(v.replace(/\s/g, '')),
      msg: 'El teléfono debe tener 10 dígitos.',
      showValid: true
    },
    tema: {
      test: v => v !== '',
      msg: 'Selecciona un tema de interés.',
      showValid: false
    },
    ocupacion: {
      test: v => v !== '',
      msg: 'Selecciona una opción.',
      showValid: false
    }
    // "mensaje" no está aquí → opcional, sin validación
  };

  function validateField(fieldId, showFeedback = true) {
    const field = document.getElementById(fieldId);
    if (!field) return true;
    const rule = rules[fieldId];
    if (!rule) return true;

    const isValid = rule.test(field.value);

    if (showFeedback) {
      // Rojo siempre que falle
      field.classList.toggle('is-invalid', !isValid);
      // Verde solo si la regla lo permite
      field.classList.toggle('is-valid', isValid && rule.showValid);

      const invalidFb = field.parentElement.querySelector('.invalid-feedback');
      if (invalidFb) invalidFb.textContent = isValid ? '' : rule.msg;
    }

    return isValid;
  }

  // Validación en vivo solo en email y teléfono (los que muestran verde)
  ['email', 'telefono'].forEach(id => {
    const field = document.getElementById(id);
    if (field) {
      field.addEventListener('input', () => validateField(id));
      field.addEventListener('blur',  () => validateField(id));
    }
  });

  // Nombre, tema y ocupacion: solo validar al perder foco (sin verde)
  ['nombre', 'tema', 'ocupacion'].forEach(id => {
    const field = document.getElementById(id);
    if (field) {
      field.addEventListener('blur', () => validateField(id));
    }
  });

  // Submit: validar todos los requeridos
  form.addEventListener('submit', function (e) {
    e.preventDefault();
    const allValid = Object.keys(rules).map(id => validateField(id, true)).every(Boolean);
    if (allValid) {
      showSuccessToast();
      form.reset();
      // Limpiar clases visuales
      Object.keys(rules).forEach(id => {
        const field = document.getElementById(id);
        if (field) field.classList.remove('is-valid', 'is-invalid');
      });
      const modal = bootstrap.Modal.getInstance(document.getElementById('contactModal'));
      if (modal) setTimeout(() => modal.hide(), 1500);
    }
  });
}

// ── Toast notification ────────────────────────
function showSuccessToast() {
  const existing = document.getElementById('successToast');
  if (existing) existing.remove();

  const toast = document.createElement('div');
  toast.id = 'successToast';
  toast.style.cssText = `
    position: fixed; bottom: 2rem; right: 2rem; z-index: 9999;
    background: var(--bg-card); border: 1px solid rgba(0,245,212,0.4);
    border-radius: 12px; padding: 1rem 1.5rem; display: flex;
    align-items: center; gap: 0.75rem;
    box-shadow: 0 10px 40px rgba(0,0,0,0.4), 0 0 20px rgba(0,245,212,0.2);
  `;
  toast.innerHTML = `
    <span style="color:#00f5d4; font-size:1.3rem;">✓</span>
    <div>
      <div style="color:#f1f5f9; font-weight:700; font-size:0.9rem;">¡Formulario enviado!</div>
      <div style="color:#94a3b8; font-size:0.8rem;">Gracias por tu interés.</div>
    </div>
  `;
  document.body.appendChild(toast);
  setTimeout(() => toast.remove(), 3500);
}

// ── Navbar scroll effect ──────────────────────
function initNavbarScroll() {
  const navbar = document.querySelector('.navbar');
  if (!navbar) return;
  window.addEventListener('scroll', () => {
    navbar.style.background = window.scrollY > 50
      ? 'rgba(10,14,26,0.98)'
      : 'rgba(10,14,26,0.92)';
  });
}

// ── Topic cards hover glow ────────────────────
function initCardGlow() {
  document.querySelectorAll('.topic-card').forEach(card => {
    card.addEventListener('mousemove', (e) => {
      const rect = card.getBoundingClientRect();
      const x = ((e.clientX - rect.left) / rect.width) * 100;
      const y = ((e.clientY - rect.top) / rect.height) * 100;
      card.style.background = `radial-gradient(circle at ${x}% ${y}%, rgba(0,245,212,0.05) 0%, var(--bg-card) 60%)`;
    });
    card.addEventListener('mouseleave', () => {
      card.style.background = 'var(--bg-card)';
    });
  });
}

// ── Init all ──────────────────────────────────
document.addEventListener('DOMContentLoaded', () => {
  setActiveNav();
  initScrollAnimations();
  initFormValidation();
  initNavbarScroll();
  initCardGlow();
});