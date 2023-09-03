describe('template spec', () => {
  it('passes', () => {
    cy.visit('http://localhost:5020/')
  })

  /* ==== Test Created with Cypress Studio ==== */
  it('ValidaNavegação', function() {
    /* ==== Generated with Cypress Studio ==== */
    cy.visit('http://localhost:5020/');
    cy.get('label').should('have.text', 'CPF:');
    cy.get(':nth-child(2) > .nav-link').click();
    cy.get('h1').should('have.text', 'Counter');
    cy.get('.btn').click();
    cy.get(':nth-child(3) > .nav-link').click();
    cy.get('h1').should('have.text', 'Weather forecast');
    /* ==== End Cypress Studio ==== */
  });
})