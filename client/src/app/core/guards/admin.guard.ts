import { inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';
import { AccountService } from '../services/account.service';
import { SnackbarService } from '../services/snackbar.service';

export const adminGuard: CanActivateFn = (route, state) => {
  const accountService = inject(AccountService);
  const router = inject(Router);
  const snack = inject(SnackbarService);

  if (accountService.isAdmin()) {
    return true;
  } else {
    snack.error('Nope');
    router.navigateByUrl('/shop');
    return false;
  }
};
// if I want to redirect someone when logging in, I need to take the same approach as auth.guard.ts, to make it observable
