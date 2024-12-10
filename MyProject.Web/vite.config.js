/*import { defineConfig } from 'vite'
import { fileURLToPath } from 'url'
import { dirname, resolve } from 'path'

const __filename = fileURLToPath(import.meta.url)
const __dirname = dirname(__filename)

export default defineConfig({
  base: '/dist/',
  build: {
    outDir: resolve(__dirname, 'wwwroot/dist'),
    emptyOutDir: true,
    manifest: true,
    rollupOptions: {
      input: resolve(__dirname, 'wwwroot/js/site.js'),
      external: ['jquery'],
      output: {
        chunkFileNames: 'js/[name]-[hash].js',
        entryFileNames: 'js/[name]-[hash].js',
        assetFileNames: 'assets/[name]-[hash][extname]',
        globals: {
          jquery: 'jQuery'
        }
      }
    }
  },
  optimizeDeps: {
    include: ['jquery', 'bootstrap']
  },
  resolve: {
    alias: {
      '~bootstrap': resolve(__dirname, 'node_modules/bootstrap'),
      jquery: resolve(__dirname, 'node_modules/jquery/dist/jquery.min.js'),
      bootstrap: resolve(__dirname, 'node_modules/bootstrap/dist/js/bootstrap.bundle.min.js')
    }
  }
})*/
import { defineConfig } from 'vite'
import { fileURLToPath } from 'url'
import { dirname, resolve } from 'path'

const __filename = fileURLToPath(import.meta.url)
const __dirname = dirname(__filename)

export default defineConfig({
  base: '/dist/',
  build: {
    outDir: resolve(__dirname, 'wwwroot/dist'),
    emptyOutDir: true,
    manifest: true,
    rollupOptions: {
      input: {
        site: resolve(__dirname, 'wwwroot/js/site.js'),
        // Thêm các entry point khác nếu cần
      },
      output: {
        chunkFileNames: 'js/[name]-[hash].chunk.js',
        entryFileNames: 'js/[name]-[hash].js',
        assetFileNames: 'assets/[name]-[hash][extname]'
      }
    }
  },
  optimizeDeps: {
    include: ['jquery', 'bootstrap', 'axios']
  },
  resolve: {
    alias: {
      '~bootstrap': resolve(__dirname, 'node_modules/bootstrap'),
      '~jquery': resolve(__dirname, 'node_modules/jquery/dist'),
      '~axios': resolve(__dirname, 'node_modules/axios/dist')
    }
  },
  css: {
    preprocessorOptions: {
      scss: {
        // Nếu sử dụng SCSS
        additionalData: `@import "./src/styles/variables.scss";`
      }
    }
  },
  server: {
    port: 5173,
    strictPort: true,
    open: true
  }
})